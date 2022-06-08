using System.Collections;

namespace DesignPatterns.Iterator
{
    public class StaffListIterator : IEnumerator<Employee>
    {
        private List<Employee> _employees;
        private int _index = -1;

        public StaffListIterator(List<Employee> employees)
        {
            _employees = employees;
        }
        public Employee Current
        {
            get
            {
                if (_index == -1 || _index >= _employees.Count)
                    throw new ArgumentException();
                return _employees[_index];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (_index < _employees.Count - 1)
            {
                _index++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => _index = -1;
        public void Dispose() { }
    }
}
