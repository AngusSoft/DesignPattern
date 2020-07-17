using System;

namespace FacadePattern
{
    public class Facade
    {
        /// <summary>
        /// 用户服务
        /// </summary>
        private readonly UserService _userService;

        /// <summary>
        /// 车辆服务
        /// </summary>
        private readonly VehicleService _vehicleService;

        public Facade()
        {
            _userService = new UserService();
            _vehicleService = new VehicleService();
        }

        /// <summary>
        /// 获取用户和车辆信息
        /// </summary>
        public void GetUserWhitVehicleInfo()
        {
            _userService.GetUserInfo();
            _vehicleService.GetVehicleInfo();
        }

    }
}
