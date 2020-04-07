namespace Quantum.Superposition
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
    operation Superposition () : Result {
        mutable initState = Zero;
        using (qubit = Qubit()){
            H(qubit);
            set initState = M(qubit);

            Reset(qubit);
		}

        return initState;
    }
}
