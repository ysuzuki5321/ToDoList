using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ToDoList.Helper;
using ToDoList.Model;

namespace ToDoList.Component
{
    public class TodoGrid : MetroGrid
    {
        private ITodoRepository<Todo> _repository;
        private BindingSource _bindingSource = new BindingSource();

        public TodoGrid()
        {
            DataSource = _bindingSource;
        }

        public void SetupGrid(ITodoRepository<Todo> repository)
        {

            _repository = repository;
            _bindingSource.DataSource = repository.ScanAllDataWithoutDeleteData();
            SetEvent();
            SetGridStyle();
            SetupDropDown();
        }

        private void SetGridStyle()
        {
            AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void SetEvent()
        {
            CellValidating += CellValidatingEvent;
            RowValidating += RowValidatingEvent;
            CellEnter += CellEnterEvent;
            CellValueChanged += CellValueChangedEvent;
            UserDeletingRow += DeletingRowEvent;
            _bindingSource.DataSourceChanged += DataSourceChangedEvent;

        }

        private void SetupDropDown()
        {
            (Columns[nameof(Priority)] as DataGridViewComboBoxColumn).SetUpSelfBinding("DisplayValue", _repository.Priorities());
            (Columns[nameof(TodoType)] as DataGridViewComboBoxColumn).SetUpTodoTypeBinding(_repository.TodoTypes());
        }

        public void TodoTypeFilter(TodoType type, bool withDeleteData)
        {
            if (type.Id < 0)
                if (withDeleteData)
                    _bindingSource.DataSource = _repository.AllData();
                else
                    _bindingSource.DataSource = _repository.ScanAllDataWithoutDeleteData();
            else _bindingSource.DataSource = _repository.TodoTypeFilter(type, withDeleteData).ToList();
        }

        public void AllData()
        {
            _bindingSource.DataSource = _repository.AllData();
        }

        public void WithoutDeleteData()
        {
            _bindingSource.DataSource = _repository.ScanAllDataWithoutDeleteData();
        }

        private void CellValidatingEvent(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (Columns[e.ColumnIndex].Name == "Limit")
            {
                var dateValue = this[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                var (resultDate, resultBool) = ValidatingHelper.CheckDateTime(dateValue);
                if (!ValidatingHelper.CheckNullOrStringEmpty(dateValue) && !resultBool)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void RowValidatingEvent(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (IsOutOfRange(e.RowIndex)) return;

            var result = _repository.TodoTableUpdate(GetBindingData(e.RowIndex));
            switch (result)
            {
                case DbUpdateType.NotComlete:
                    ChangeRowColor(!Rows[e.RowIndex].IsNewRow, e.RowIndex, Color.LightPink);
                    break;
                default:
                    ChangeDisabledRowColor(e.RowIndex);
                    break;
            }
        }

        private bool IsOutOfRange(int index) => GetTodoList().Count() <= index;
        private Todo GetBindingData(int index)
        {
            return GetTodoList()[index];
        }

        private List<Todo> GetTodoList()
        {
            return _bindingSource.DataSource as List<Todo>;
        }

        private void CellEnterEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                BeginEdit(false);
                var edit = EditingControl as DataGridViewComboBoxEditingControl;
                edit.DroppedDown = true;
            }
        }

        private Dictionary<int, Color> _defaultRowColor = new Dictionary<int, Color>();

        private void CellValueChangedEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                ChangeDisabledRowColor(e.RowIndex);
            }
        }

        private void ChangeDisabledRowColor(int rowIndex)
        {
            var data = GetBindingData(rowIndex);
            ChangeRowColor(data.Done, rowIndex, Color.LightGray);
        }

        private void ChangeDefaultRowColor(int rowIndex)
        {
            ChangeRowColor(false, rowIndex, Color.White);
        }

        private void ChangeRowColor(bool cond, int rowIndex, Color changeColor)
        {
            if (!_defaultRowColor.ContainsKey(rowIndex))
                _defaultRowColor.Add(rowIndex, Rows[rowIndex].DefaultCellStyle.BackColor);
            Rows[rowIndex].DefaultCellStyle.BackColor
                = cond ? changeColor : _defaultRowColor[rowIndex];
        }

        private void DataSourceChangedEvent(object sender, EventArgs e)
        {
            var list = GetTodoList();
            if (list == null) return;
            for (var index = 0; index < list.Count(); index++)
            {
                ChangeDisabledRowColor(index);
            }
        }

        private void DeletingRowEvent(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Do you delete this row?"
                , "Delete Confirm"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                _repository.Delete(GetBindingData(e.Row.Index));
            }
            else e.Cancel = true;
        }
    }
}
