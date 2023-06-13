using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOITool
{
    public static class StrConversion
    {
        public static string ProcessConstructionMassInput(string input)
        {
            string output = string.Empty;
            switch (input)
            {
                case "5f":
                    output = "TIER_TINY";
                    break;
                case "25f":
                    output = "TIER0";
                    break;
                case "50f":
                    output = "TIER1";
                    break;
                case "100f":
                    output = "TIER2";
                    break;
                case "200f":
                    output = "TIER3";
                    break;
                case "400f":
                    output = "TIER4";
                    break;
                case "800f":
                    output = "TIER5";
                    break;
                case "1200f":
                    output = "TIER6";
                    break;
                case "2000f":
                    output = "TIER7";
                    break;
                default:
                    // 处理未匹配到的情况，例如保留原值或抛出异常等
                    break;
            }
            return output;
        }
        public static string ProcessConstruction_materialsInput(string input)
        {
            string output = string.Empty;
            switch (input)
            {
                case "所有金属":
                    output = "ALL_METALS";
                    break;
                case "原始金属":
                    output = "RAW_METALS";
                    break;
                case "精炼金属":
                    output = "REFINED_METALS";
                    break;
                case "合金":
                    output = "ALLOYS";
                    break;
                case "所有矿物":
                    output = "ALL_MINERALS";
                    break;
                case "原始矿物":
                    output = "RAW_MINERALS";
                    break;
                case "精炼矿物":
                    output = "REFINED_MINERALS";
                    break;
                case "珍贵岩石":
                    output = "PRECIOUS_ROCKS";
                    break;
                case "可耕种的":
                    output = "FARMABLE";
                    break;
                case "水管材料":
                    output = "PLUMBABLE";
                    break;
                case "塑料":
                    output = "PLASTICS";
                    break;
                case "玻璃":
                    output = "GLASSES";
                    break;
                case "透明材料":
                    output = "TRANSPARENTS";
                    break;
                case "植物纤维":
                    output = "BUILDING_FIBER";
                    break;
                case "任意可建造的":
                    output = "ANY_BUILDABLE";
                    break;
                case "飞行生物食物":
                    output = "FLYING_CRITTER_FOOD";
                    break;
                case "辐射防护":
                    output = "RADIATION_CONTAINMENT";
                    break;
                default:
                    // 处理未匹配到的情况，例如保留原值或抛出异常等
                    break;
            }

            return output;
        }
        public static string ProcessBuild_location_ruleInput(string input)
        {
            string output = string.Empty;
            switch (input)
            {
                case "任意位置":
                    output = "Anywhere";
                    break;
                case "在地板上":
                    output = "OnFloor";
                    break;
                case "在地板上方":
                    output = "OnFloorOverSpace";
                    break;
                case "在天花板上":
                    output = "OnCeiling";
                    break;
                case "在墙壁上":
                    output = "OnWall";
                    break;
                case "在角落":
                    output = "InCorner";
                    break;
                case "方块":
                    output = "Tile";
                    break;
                case "不在方块内":
                    output = "NotInTiles";
                    break;
                case "导管":
                    output = "Conduit";
                    break;
                case "逻辑桥":
                    output = "LogicBridge";
                    break;
                case "电线桥":
                    output = "WireBridge";
                    break;
                case "高电力桥方块":
                    output = "HighWattBridgeTile";
                    break;
                case "建筑附着点":
                    output = "BuildingAttachPoint";
                    break;
                case "在地板上或建筑附着点上":
                    output = "OnFloorOrBuildingAttachPoint";
                    break;
                case "在可旋转的基础上":
                    output = "OnFoundationRotatable";
                    break;
                case "在火箭天花板下方":
                    output = "BelowRocketCeiling";
                    break;
                case "在火箭外壳上":
                    output = "OnRocketEnvelope";
                    break;
                case "墙壁与地板":
                    output = "WallFloor";
                    break;
                case "原点无液体导管":
                    output = "NoLiquidConduitAtOrigin";
                    break;
                default:
                    // 处理未匹配到的情况，例如保留原值或抛出异常等
                    break;
            }

            return output;
        }
    }
}
