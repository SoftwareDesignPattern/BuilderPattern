using BuilderPattern.VM;

namespace BuilderPattern.Interface
{
    interface IBuilderPhone
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
}
