namespace MoneyExtension.Tests
{
    [TestClass]
    public sealed class MoneyExtensionsTests
    {
        [TestMethod]
        public void ShouldConvertDecilmalToInt()
        {
            decimal valor = 279.55m;
            var cents = valor.ToCents();

            Assert.AreEqual(27955,cents);
        }
    }
}
