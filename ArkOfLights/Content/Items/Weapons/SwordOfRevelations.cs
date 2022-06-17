﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Weapons
{
    public class SwordOfRevelations : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A great sword made from Pure Light");
        }

        public override void SetDefaults()
        {
            Item.damage = 700;
            Item.DamageType = DamageClass.Melee;
            Item.crit = 45;
            Item.width = 64;
            Item.height = 64;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = 1;
            Item.knockBack = 14;
            Item.value = 1000000;
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Frostburn2, 300);
            target.AddBuff(BuffID.Bleeding, 300);
            //target.AddBuff(BuffID.ImperialQuake, 60);
        }

        //public override void ModifyTooltips(List<TooltipLine> tooltips)
        //{
        //    foreach (TooltipLine line2 in tooltips)
        //    {
        //        if (line2.Mod == )
        //   }
        //}
    }
}
