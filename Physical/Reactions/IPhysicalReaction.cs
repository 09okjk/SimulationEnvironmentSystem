using Physical.Properties;

namespace Physical.Reactions
{
    public interface IPhysicalReaction
    {
        void React(BasePhysicalProperty property);
    }
}