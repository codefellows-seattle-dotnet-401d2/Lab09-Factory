using Factory;

namespace Creator
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new CoverLetter(1));
            Pages.Add(new WorkHistory(2));
            Pages.Add(new Education(3));
            Pages.Add(new References(4));
        }
    }
}
