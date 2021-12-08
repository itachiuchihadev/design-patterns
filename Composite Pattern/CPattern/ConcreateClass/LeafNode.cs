using System;

namespace CPattern
{
    public class LeafNode : Component
    {
        public override string Operation()
        {
            return "LEAF NODE";
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}