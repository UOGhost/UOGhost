using System;

namespace Server.Mobiles
{
    public class WarriorGuildmaster : BaseGuildmaster
    {
        [Constructable]
        public WarriorGuildmaster()
            : base("warrior")
        {
            this.SetSkill(SkillName.Parry, 100.0);
            this.SetSkill(SkillName.MagicResist, 100.0);
            this.SetSkill(SkillName.Tactics, 100.0);
            this.SetSkill(SkillName.Swords, 100.0);
            this.SetSkill(SkillName.Macing, 100.0);
            this.SetSkill(SkillName.Fencing, 100.0);
        }

        public WarriorGuildmaster(Serial serial)
            : base(serial)
        {
        }

        public override NpcGuild NpcGuild
        {
            get
            {
                return NpcGuild.WarriorsGuild;
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