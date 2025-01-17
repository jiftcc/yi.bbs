﻿using CC.Yi.IDAL;
using CC.Yi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CC.Yi.DAL
{
    public partial class plateDal : BaseDal<plate>, IplateDal
    {
        public plateDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class discussDal : BaseDal<discuss>, IdiscussDal
    {
        public discussDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class commentDal : BaseDal<comment>, IcommentDal
    {
        public commentDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class userDal : BaseDal<user>, IuserDal
    {
        public userDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class roleDal : BaseDal<role>, IroleDal
    {
        public roleDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class actionDal : BaseDal<action>, IactionDal
    {
        public actionDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class levelDal : BaseDal<level>, IlevelDal
    {
        public levelDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class user_extraDal : BaseDal<user_extra>, Iuser_extraDal
    {
        public user_extraDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class labelDal : BaseDal<label>, IlabelDal
    {
        public labelDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class collectionDal : BaseDal<collection>, IcollectionDal
    {
        public collectionDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class bannerDal : BaseDal<banner>, IbannerDal
    {
        public bannerDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class agreeDal : BaseDal<agree>, IagreeDal
    {
        public agreeDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class versionDal : BaseDal<version>, IversionDal
    {
        public versionDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class shopDal : BaseDal<shop>, IshopDal
    {
        public shopDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class warehouseDal : BaseDal<warehouse>, IwarehouseDal
    {
        public warehouseDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class propDal : BaseDal<prop>, IpropDal
    {
        public propDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class friendDal : BaseDal<friend>, IfriendDal
    {
        public friendDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class articleDal : BaseDal<article>, IarticleDal
    {
        public articleDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class recordDal : BaseDal<record>, IrecordDal
    {
        public recordDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
    public partial class mytypeDal : BaseDal<mytype>, ImytypeDal
    {
        public mytypeDal(DataContext _Db):base(_Db)
        {
            Db = _Db;
        }
    }
}