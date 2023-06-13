using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOITool
{
    public static class BasicTemplate
    {


        public static string Obtain_DLL = $@"
<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net6.0-windows</TargetFramework>
    <Nullable>enable</Nullable>
    <UseWindowsForms>true</UseWindowsForms>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include=""0Harmony"">
      <HintPath>..\..\..\..\..\..\..\..\..\..\Program Files (x86)\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed\0Harmony.dll</HintPath>
    </Reference>
    <Reference Include=""Assembly-CSharp"">
      <HintPath>..\..\..\..\..\..\..\..\..\..\Program Files (x86)\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed\Assembly-CSharp.dll</HintPath>
    </Reference>
    <Reference Include=""Assembly-CSharp-firstpass"">
      <HintPath>..\..\..\..\..\..\..\..\..\..\Program Files (x86)\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed\Assembly-CSharp-firstpass.dll</HintPath>
    </Reference>
    <Reference Include=""UnityEngine.CoreModule"">
      <HintPath>..\..\..\..\..\..\..\..\..\..\Program Files (x86)\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed\UnityEngine.CoreModule.dll</HintPath>
    </Reference>
  </ItemGroup>

</Project>
            ";

        public static string Obtain_modyml = $@"title: ""Template"" 
";

        public static string Obtain_mod_infoyml = $@"supportedContent: ALL
minimumSupportedBuild: 498381
version: 1.0
APIVersion: 2
";

        public static string Obtain_Template(string userInput, string widthInput, string heightInput, string animInput, string hitpointsInput, string construction_timeInput, string construction_massInput, string construction_materialsInput, string melting_pointInput, string build_location_ruleInput, string tier2_amountInput, string tier2_radiusInput, string muban)
        {
            return $@"
using System.Collections.Generic;
using TUNING;
using UnityEngine;
namespace {userInput}_Patch
{{
    public class {userInput}Config : IBuildingConfig
    {{
        public override BuildingDef CreateBuildingDef()
        {{
            string id = ""{userInput}"";
            int width = {widthInput};
            int height = {heightInput};
            string anim = ""{animInput}_kanim"";
            int hitpoints = {hitpointsInput};
            float construction_time = {construction_timeInput}f;
            float[] tier = BUILDINGS.CONSTRUCTION_MASS_KG.{StrConversion.ProcessConstructionMassInput(construction_massInput)};
            string[] all_METALS = MATERIALS.{StrConversion.ProcessConstruction_materialsInput(construction_materialsInput)};
            float melting_point = {melting_pointInput}f;
            BuildLocationRule build_location_rule = BuildLocationRule.{StrConversion.ProcessBuild_location_ruleInput(build_location_ruleInput)};
            EffectorValues tier2 = new EffectorValues
            {{
                amount = {tier2_amountInput},
                radius = {tier2_radiusInput}
            }};
            BuildingDef buildingDef = BuildingTemplates.CreateBuildingDef(id, width, height, anim, hitpoints, construction_time, tier, all_METALS, melting_point, build_location_rule, BUILDINGS.DECOR.PENALTY.TIER2, tier2, 0.2f);

            buildingDef.OverheatTemperature = 0f/* 填写相应的过热温度 */;
            buildingDef.RequiresPowerInput = true/* 填写相应的是否需要电力输入 */;
            buildingDef.EnergyConsumptionWhenActive = 0f /* 填写相应的激活时的能量消耗 */;
            buildingDef.SelfHeatKilowattsWhenActive = 0f /* 填写相应的激活时的自身热量 */;
            buildingDef.ViewMode = OverlayModes.Light.ID/* 填写相应的视图模式 */;
            buildingDef.AudioCategory = ""Metal""/* 填写相应的音频类别 */;

            return buildingDef;
        }}

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {{
            {muban}
        }}

        public override void DoPostConfigureComplete(GameObject go)
        {{

        }}
    }}
}}";
        }

    }
}
