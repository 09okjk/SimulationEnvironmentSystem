using Chemical.Reactions;
using Physical.Reactions;
using SimulationEnvironmentSystem.Items;

class Program
{
    static void Main(string[] args)
    {
        Material material = new Material();
        
        // 物理反应：加热
        material.physicalProperty.temperature.Value = 20;
        IPhysicalReaction heatReaction = new HeatReaction();
        material.ApplyPhysicalReaction(heatReaction);
        
        
        // 化学反应：燃烧
        material.chemicalProperty.flame.IsOn = true;
        IChemicalReaction combustionReaction = new CombustionReaction();
        material.ApplyChemicalReaction(combustionReaction);
    }
}