using System;
using System.Collections.Generic;

namespace CPattern
{
    public class FirstParent : Component
    {
        public List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }
        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
        public override string Operation()
        {
            string val = "First_Parent";
            foreach (var comp in this._children)
            {
                val = string.Concat(val, " + ", comp.Operation());
            }
            return val;
        }
    }
}