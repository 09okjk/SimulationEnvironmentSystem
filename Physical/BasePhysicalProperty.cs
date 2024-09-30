using Physical.Reactions;

namespace Physical.Properties
{
    public class BasePhysicalProperty
    {
        public Mass mass { get; set; } = new Mass(0);
        public Temperature temperature { get; set; } = new Temperature(0);
        
        public void ApplyPhysicalReaction(IPhysicalReaction reaction)
        {
            reaction.React(this);
        }
    }
}