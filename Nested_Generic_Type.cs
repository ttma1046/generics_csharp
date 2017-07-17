class Container<T, U>
{
    // Nested classes inherit type parameters.
    // Reusing a type parameter name will cause
    // a warning
    class Nested<U>
    {
        void Method(T param0, U param1)
        {

        }
    }
}

/*
“The containing type’s type parameters are accessible in the nested type the same way that members of the containing type are also accessible from the nested type. 
The rule is simply that a type parameter is available anywhere within the body of the type that declares it.”
 */