using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Business.Model.Users;
using Todolist.Business.Service.Contract;
using Todolist.Data.Repository.Contract;

namespace Todolist.Business.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ReadUserDto>> GetUsers()
        {
            var users = await _userRepository.GetAllAsync().ConfigureAwait(false);
            return _mapper.Map<List<ReadUserDto>>(users);
        }

    }
}
