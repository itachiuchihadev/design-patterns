using System;
using System.Collections.Generic;

namespace CPattern
{
    public class FirstGrandParent : Component
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
            string val = "First_GrandParent";
            foreach (var comp in this._children)
            {
                val = string.Concat(val, " + ", comp.Operation());
            }
            return val;
        }
    }
}