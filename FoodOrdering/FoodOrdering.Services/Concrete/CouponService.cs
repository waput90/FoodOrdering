using System;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Commons.Enums;
using FoodOrdering.Commons.Extensions;
using FoodOrdering.Commons.ViewModel;
using FoodOrdering.Data.Access.Patterns.Factory;
using FoodOrdering.Data.Models;
using FoodOrdering.Services.Abstract;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Services.Concrete
{
    public class CouponService : ICouponService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly ILogger<CouponService> _logger;
        public CouponService(
            IUnitOfWorkFactory unitOfWorkFactory,
            ILogger<CouponService> logger)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _logger = logger;
        }

        public async Task<GetCouponResponseModel> GetCouponByName(string name)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    using (var uow = _unitOfWorkFactory.CreateUow())
                    {
                        var coupons = (await uow.GetEntityRepository<Coupon>()
                                                .ItemsAsync(q => q.Name.Equals(name, StringComparison.CurrentCulture)))
                                                .FirstOrDefault();

                        if (!coupons.IsNull())
                            return new GetCouponResponseModel
                            {
                                Id = coupons.Id,
                                Discount = coupons.Discount,
                                IsAvail = coupons.IsUsed.Equals(CouponEnum.USED) ? false : true,
                                IsValid = DateTime.Now.GetDate() > coupons.Validity ? false : true
                            };
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return default;
        }

        public async Task<bool> UseCoupon(string couponId)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(couponId))
                {
                    using (var uow = _unitOfWorkFactory.CreateUow())
                    {
                        var coupons = await uow.GetEntityRepository<Coupon>()
                                                .FindAsync(couponId);

                        if (coupons != null)
                        {
                            coupons.IsUsed = CouponEnum.USED;
                            uow.GetEntityRepository<Coupon>().Update(coupons);
                            await uow.Commit();
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return false;
        }
    }
}