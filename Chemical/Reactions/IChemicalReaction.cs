using Chemical.Properties;

namespace Chemical.Reactions
{
    public interface IChemicalReaction
    {
        void React(BaseChemicalProperty property);
    }
}