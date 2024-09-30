using Chemical.Reactions;

namespace Chemical.Properties
{
    public class BaseChemicalProperty
    {
        public PH ph { get; set; } = new PH(0);
        public Flame flame { get; set; } = new Flame(false);
        
        public void ApplyChemicalReaction(IChemicalReaction reaction)
        {
            reaction.React(this);
        }
    }
}