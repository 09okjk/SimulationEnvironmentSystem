using Physical.Properties;

namespace Physical.Reactions
{
    public class HeatReaction : IPhysicalReaction
    {
        public void React(BasePhysicalProperty property)
        {
            property.temperature.Value += 1;
            Console.WriteLine($"物质温度增加1，当前温度为{property.temperature.Value}\u00b0C");
        }
    }
}