// <auto-generated>
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Superposition\",\"Name\":\"Superposition\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Superposition\",\"Name\":\"Superposition\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Superposition
{
    [SourceLocation("C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs", OperationFunctor.Body, 6, -1)]
    public partial class Superposition : Operation<QVoid, Result>, ICallable
    {
        public Superposition(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Superposition";
        String ICallable.FullName => "Quantum.Superposition.Superposition";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line 7 "C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs"
            var state = Result.Zero;
#line hidden
            {
#line 8 "C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs"
                var qubit = Allocate.Apply();
#line hidden
                System.Runtime.ExceptionServices.ExceptionDispatchInfo __arg1__ = null;
                try
                {
#line 9 "C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs"
                    MicrosoftQuantumIntrinsicH.Apply(qubit);
#line 10 "C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs"
                    state = MicrosoftQuantumIntrinsicM.Apply(qubit);
#line 12 "C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(qubit);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(__arg2__);
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        __arg1__.Throw();
                    }

#line hidden
                    Release.Apply(qubit);
                }
            }

#line 15 "C:/Users/Chuck/Desktop/Authorship/WIP%20-%20Q%23%20Getting%20Started/Module%203%20-%20Superposition/Superposition/Superposition/Superposition.qs"
            return state;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<Superposition, QVoid, Result>(QVoid.Instance);
        }
    }
}