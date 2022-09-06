using NUnit.Framework;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthTests
{
    [Test]
    public void WhenReplenishHeartWith0Pieces_ImageIsFilledWith0PercentAmount()
    {
        var image = new GameObject().AddComponent<Image>();
        image.fillAmount = 0;
        var heart = new Heart(image);

        heart.Replenish(0); 

        Assert.Equals(0, image.fillAmount);
    }
}

public class Heart
{
    private Image image;

    public Heart(Image image)
    {
        this.image = image;
    }

    public void Replenish(int numberOfHeartPieces)
    {
        throw new NotImplementedException();
    }
}