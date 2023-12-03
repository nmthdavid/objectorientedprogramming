using nagybeadandokod;
namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BeolvasTest()
    {
        Onkormanyzat onkormanyzat = Program.beolvas();
        Assert.AreEqual(onkormanyzat.jarmuvek.Count, 5);
    }

    [TestMethod]
    public void BeolvasTest2()
    {
        Onkormanyzat onkormanyzat = Program.beolvas();
        Assert.AreEqual(onkormanyzat.cegek.Count, 2);
    }

    [TestMethod]
    public void BeolvasTest3()
    {
        Onkormanyzat onkormanyzat = Program.beolvas();
        Assert.AreEqual(onkormanyzat.varos, "Nagykanizsa");
    }

    [TestMethod]
    public void MennyireOregTEST()
    {
        Onkormanyzat onkormanyzat = Program.beolvas();
        Assert.AreEqual(onkormanyzat.mennyireOreg(), 0.3333333333333333);
    }

    [TestMethod]
    public void MaxErtTEST()
    {
        Onkormanyzat onkormanyzat = Program.beolvas();
        Assert.AreEqual(onkormanyzat.maxErtek(), 10000000);
    }



}
