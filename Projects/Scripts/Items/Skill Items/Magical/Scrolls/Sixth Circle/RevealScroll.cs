namespace Server.Items
{
  public class RevealScroll : SpellScroll
  {
    [Constructible]
    public RevealScroll(int amount = 1) : base(47, 0x1F5C, amount)
    {
    }

    public RevealScroll(Serial serial) : base(serial)
    {
    }

    public override void Serialize(GenericWriter writer)
    {
      base.Serialize(writer);

      writer.Write(0); // version
    }

    public override void Deserialize(GenericReader reader)
    {
      base.Deserialize(reader);

      int version = reader.ReadInt();
    }
  }
}