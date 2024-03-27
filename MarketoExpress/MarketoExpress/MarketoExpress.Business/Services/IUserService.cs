using MarketoExpress.Business.Dtos;
using MarketoExpress.Business.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketoExpress.Business.Services
{
	public interface IUserService
	{
		ServiceMessage AddUser(AddUserDto addUserDto);
		UserInfoDto LoginUser(LoginDto loginDto);
	}
}
