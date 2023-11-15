namespace WatchAPi;
using FluentAssertions;
using Xunit;

public class WatchApiHelperTests
{
    [Fact]
    public void CheckoutTotal_ShouldCalculateTotalCorrectly_WithDiscounts()
    {
        var watchesInCart = new int[] { 1, 1, 2, 2, 2, 3, 4 };

        var result = WatchApiHelper.CheckoutTotal(watchesInCart);

        result.Should().Be(480);
    }

    [Fact]
    public void CheckoutTotal_ShouldCalculateTotalCorrectly_WithoutDiscounts()
    {
        var watchesInCart = new int[] { 3, 4, 3, 4, 3 };

        var result = WatchApiHelper.CheckoutTotal(watchesInCart);

        result.Should().Be(210);
    }

    [Fact]
    public void CheckoutTotal_ShouldBeZero_WhenZeroPassed()
    {
        var watchesInCart = new int[] { 0 };

        var result = WatchApiHelper.CheckoutTotal(watchesInCart);

        result.Should().Be(0);
    }

    [Fact]
    public void CheckoutTotal_ShouldBeZero_WhenEmptyPassed()
    {
        var watchesInCart = new int[] { };

        var result = WatchApiHelper.CheckoutTotal(watchesInCart);

        result.Should().Be(0); 
    }

    [Fact]
    public void CheckoutTotal_ShouldBeZero_WhenIDOutsideOfRangePassed()
    {
        var watchesInCart = new int[] { 5 };

        var result = WatchApiHelper.CheckoutTotal(watchesInCart);

        result.Should().Be(0); 
    }
}
