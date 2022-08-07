// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class KnowYourEnemy
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> kye_ab_small => Construct(0x81e);
            public static FormLink<ISpellGetter> kye_ab_undead => Construct(0x820);
            public static FormLink<ISpellGetter> kye_ab_venomous => Construct(0x821);
            public static FormLink<ISpellGetter> kye_ab_ice_elemental => Construct(0x822);
            public static FormLink<ISpellGetter> kye_ab_fire_elemental => Construct(0x823);
            public static FormLink<ISpellGetter> kye_ab_shock_elemental => Construct(0x824);
            public static FormLink<ISpellGetter> kye_ab_plant => Construct(0x825);
            public static FormLink<ISpellGetter> kye_ab_vile => Construct(0x826);
            public static FormLink<ISpellGetter> kye_ab_skeletal => Construct(0x827);
            public static FormLink<ISpellGetter> kye_ab_troll_kin => Construct(0x828);
            public static FormLink<ISpellGetter> kye_ab_weak_willed => Construct(0x829);
            public static FormLink<ISpellGetter> kye_ab_strong_willed => Construct(0x82a);
            public static FormLink<ISpellGetter> kye_ab_cave_dwelling => Construct(0x82b);
            public static FormLink<ISpellGetter> kye_ab_vascular => Construct(0x82c);
            public static FormLink<ISpellGetter> kye_ab_supernatural => Construct(0x82d);
            public static FormLink<ISpellGetter> kye_ab_ghostly => Construct(0x847);
            public static FormLink<ISpellGetter> kye_ab_rocky => Construct(0x865);
            public static FormLink<ISpellGetter> kye_armor_description_ab => Construct(0x88e);
            public static FormLink<ISpellGetter> kye_inspect_spell => Construct(0x886);
            public static FormLink<ISpellGetter> kye_ab_dwarven_machine => Construct(0x81f);
            public static FormLink<ISpellGetter> kye_ab_aquatic => Construct(0x81a);
            public static FormLink<ISpellGetter> kye_ab_furred => Construct(0x81b);
            public static FormLink<ISpellGetter> kye_ab_fat => Construct(0x81c);
            public static FormLink<ISpellGetter> kye_ab_big => Construct(0x81d);
        }
    }
}