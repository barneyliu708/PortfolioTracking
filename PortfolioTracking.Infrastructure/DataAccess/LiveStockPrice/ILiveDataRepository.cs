using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto;

namespace PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice
{
    public interface ILiveDataRepository
    {
        StockPriceDto GetLastStockPrice(string ticker);
    }
}