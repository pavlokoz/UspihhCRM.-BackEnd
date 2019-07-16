﻿using System.Collections.Generic;

namespace Uspihh.Services.Services
{
    public interface IService<T>
    {
        T GetById(long id);
        void Create(T entity);
        void Delete(T entity);
        IList<T> GetAll();
    }
}
