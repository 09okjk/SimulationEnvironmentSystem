using Chemical.Properties;

namespace Chemical.Reactions
{
    public class CombustionReaction:IChemicalReaction
    {
        public void React(BaseChemicalProperty property)
        {
            if (property.flame.IsOn)
            {
                Console.WriteLine("物质发生燃烧反应！");
            }
            else
            {
                Console.WriteLine("物质不易燃，未发生反应。");
            }
        }
    }
}