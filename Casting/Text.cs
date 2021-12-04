using System;

namespace colony_builder.Casting
{
    public class Text : Actor
    {
        public Text(Point position, string text)
        {
            SetPosition(position);
            SetText(text);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
