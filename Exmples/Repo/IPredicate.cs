using Exmples.ViewModel;

namespace Exmples
{
    public interface IPredicate
    {
        string Main();

        string PredicateMain2();

        string PredicateMain3();

        string PredicateMain4();

        Employee PredicateMain5();

        string DelegateMulticast();

        string DelegateSinglecast();

        string DelegateGeneric();
    }
}
