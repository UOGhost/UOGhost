using System;

namespace Server.Mobiles
{
    public class RangerGuildmaster : BaseGuildmaster
    {
        [Constructable]
        public RangerGuildmaster()
            : base("ranger")
        {
            this.SetSkill(SkillName.Camping, 100.0);
            this.SetSkill(SkillName.Tactics, 100.0);
            this.SetSkill(SkillName.Archery, 100.0);
            this.SetSkill(SkillName.Lumberjacking, 100.0);
            this.SetSkill(SkillName.Fletching, 100.0);
            this.SetSkill(SkillName.Carpentry, 100.0);
            this.SetSkill(SkillName.Tracking, 100.0);
        }

        public RangerGuildmaster(Serial serial)
            : base(serial)
        {
        }

        public override NpcGuild NpcGuild
        {
            get
            {
                return NpcGuild.RangersGuild;
            }
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