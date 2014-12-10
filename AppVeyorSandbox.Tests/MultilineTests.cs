using System.Runtime.CompilerServices;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace AppVeyorSandbox.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class MultilineTests
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        [Fact]
        public void Multiline1()
        {
            Approvals.Verify(@"This
Is
A
Simple
Multiline
String
");
        }
    }
}