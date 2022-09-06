using NUnit.Framework;
using UnityEngine.UI;

public class HealthTests
{
    [Test]
    public void TestReplenish()
    {
        var image = new Image();
        var heart = new Heart(image);

        heart.Replenish(0); 

        Assert.Equals(0, image.fillAmount);
    }
}
