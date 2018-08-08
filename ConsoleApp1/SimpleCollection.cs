using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SimpleCollection
    {
        private List<int> _simpleColl = new List<int>();
        private List<Func<int, bool>> _filters = new List<Func<int, bool>>();

        public SimpleCollection AddRange(params int[] values)
        {
            this._simpleColl.AddRange(values);
            return this;
        }

        public SimpleCollection ApplyFilter(Func<int, bool> filter)
        {
            _filters.Add(filter);
            return this;
        }

        public void ClearFilter() => this._filters.Clear();

        public List<int> GetCollection()
        {
            if (this._filters.Count == 0) return this._simpleColl;

            IEnumerable<int> resultCollection = _simpleColl;

            foreach (var filter in _filters)
            {
                resultCollection  = resultCollection.Where(filter);
            }

            return resultCollection.ToList();
        }
    }
}
