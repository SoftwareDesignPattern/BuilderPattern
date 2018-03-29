using BuilderPattern.Interface;

namespace BuilderPattern
{
    class Manufacturer
    {
        public void Construct(IBuilderPhone phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
