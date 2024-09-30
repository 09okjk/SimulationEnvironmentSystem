using Chemical.Properties;
using Chemical.Reactions;
using Physical.Properties;
using Physical.Reactions;

namespace SimulationEnvironmentSystem.Items
{
    public class Material
    {
        public BasePhysicalProperty physicalProperty { get; set; } = new BasePhysicalProperty();
        public BaseChemicalProperty chemicalProperty { get; set; } = new BaseChemicalProperty();
        
        public void ApplyPhysicalReaction(IPhysicalReaction reaction)
        {
            physicalProperty.ApplyPhysicalReaction(reaction);
        }
        public void ApplyChemicalReaction(IChemicalReaction reaction)
        {
            chemicalProperty.ApplyChemicalReaction(reaction);
        }
    }
}