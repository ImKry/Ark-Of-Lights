using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material
{
    public class EssenceofClarity : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Essence of Clarity");
            Tooltip.SetDefault("A key component in\nEnlightening Equipments\n[c/04c3f9:Epic Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = ItemRarityID.Purple;
            Item.maxStack = 99;
            Item.value = Item.sellPrice(gold: 10);
        }

        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<EssenceofClarity>());
            }
        }
    }
}
