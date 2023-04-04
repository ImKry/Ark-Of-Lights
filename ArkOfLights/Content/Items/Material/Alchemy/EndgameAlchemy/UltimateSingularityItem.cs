﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

//Note = Make this item useful in future update, this is a note to my self and other contributor
//Ideas and suggestion are open so if you have any idea what to use this item for, let us know
namespace ArkOfLights.Content.Items.Material.Alchemy.EndgameAlchemy
{
    public class UltimateSingularityItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Singularity");
            Tooltip.SetDefault("The true and ultimate form of a Singularity...\n[c/04c3f9:Devine Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 89;
            Item.height = 89;
            Item.rare = ItemRarityID.Cyan;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(platinum: 999);
        }
    }
}
