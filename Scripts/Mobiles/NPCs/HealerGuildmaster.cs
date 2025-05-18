using System;

namespace Server.Mobiles
{
    public class HealerGuildmaster : BaseGuildmaster
    {
        [Constructable]
        public HealerGuildmaster()
            : base("healer")
        {
            this.SetSkill(SkillName.Anatomy, 100.0);
            this.SetSkill(SkillName.Healing, 100.0);
            this.SetSkill(SkillName.Forensics, 100.0);
            this.SetSkill(SkillName.MagicResist, 100.0);
            this.SetSkill(SkillName.SpiritSpeak, 100.0);
        }

        public HealerGuildmaster(Serial serial)
            : base(serial)
        {
        }

        public override NpcGuild NpcGuild
        {
            get
            {
                return NpcGuild.HealersGuild;
            }
        }
        public override VendorShoeType ShoeType
        {
            get
            {
                return VendorShoeType.Sandals;
            }
        }
        public override void InitOutfit()
        {
            base.InitOutfit();

            this.AddItem(new Server.Items.Robe(Utility.RandomYellowHue()));
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}