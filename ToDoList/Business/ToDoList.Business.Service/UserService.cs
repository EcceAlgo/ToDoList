using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Repository.Contract;

namespace ToDoList.Business.Service
{
    public class UserService
    {
        /// <summary>
        /// Le repository de User
        /// </summary>
        private readonly IUserRepository _userRepository;

        private readonly IMapper _mapper;

        /// <summary>
        /// Initialise une nouvelle instance de UserService
        /// </summary>
        /// <param name="userRepository"></param>
        public UserService (IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


    }
}
