﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_devloEntities : DbContext
    {
        public db_devloEntities()
            : base("name=db_devloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<CONTACT> CONTACTS { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }
        public virtual DbSet<SALES_CAB> SALES_CAB { get; set; }
        public virtual DbSet<SALES_LIN> SALES_LIN { get; set; }
        public virtual DbSet<STATE> STATES { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIERS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<V_CONTACTS> V_CONTACTS { get; set; }
        public virtual DbSet<V_PRODUCTS> V_PRODUCTS { get; set; }
        public virtual DbSet<V_SALES> V_SALES { get; set; }
        public virtual DbSet<V_SALESEDIT> V_SALESEDIT { get; set; }
        public virtual DbSet<View_CONTACTS> View_CONTACTS { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<ipv6_database_firewall_rules> ipv6_database_firewall_rules { get; set; }
    
        public virtual int PA_ADD_CATEGORY(string nAME, string dESCRIPTION, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ADD_CATEGORY", nAMEParameter, dESCRIPTIONParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_ADD_CONTACT(string nAME, string sURNAMES, string pHONE, string eMAIL, string aDDRESS, string rOLE, string oBSERVATIONS, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var sURNAMESParameter = sURNAMES != null ?
                new ObjectParameter("SURNAMES", sURNAMES) :
                new ObjectParameter("SURNAMES", typeof(string));
    
            var pHONEParameter = pHONE != null ?
                new ObjectParameter("PHONE", pHONE) :
                new ObjectParameter("PHONE", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var aDDRESSParameter = aDDRESS != null ?
                new ObjectParameter("ADDRESS", aDDRESS) :
                new ObjectParameter("ADDRESS", typeof(string));
    
            var rOLEParameter = rOLE != null ?
                new ObjectParameter("ROLE", rOLE) :
                new ObjectParameter("ROLE", typeof(string));
    
            var oBSERVATIONSParameter = oBSERVATIONS != null ?
                new ObjectParameter("OBSERVATIONS", oBSERVATIONS) :
                new ObjectParameter("OBSERVATIONS", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ADD_CONTACT", nAMEParameter, sURNAMESParameter, pHONEParameter, eMAILParameter, aDDRESSParameter, rOLEParameter, oBSERVATIONSParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_ADD_PRODUCT(Nullable<int> cODE, string nAME, string dESCRIPTION, Nullable<int> cATEGORY, Nullable<int> sUPPLIER, Nullable<int> sTOCK, Nullable<decimal> sELL_PRICE, Nullable<decimal> sUPLIER_PRICE, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cODEParameter = cODE.HasValue ?
                new ObjectParameter("CODE", cODE) :
                new ObjectParameter("CODE", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var cATEGORYParameter = cATEGORY.HasValue ?
                new ObjectParameter("CATEGORY", cATEGORY) :
                new ObjectParameter("CATEGORY", typeof(int));
    
            var sUPPLIERParameter = sUPPLIER.HasValue ?
                new ObjectParameter("SUPPLIER", sUPPLIER) :
                new ObjectParameter("SUPPLIER", typeof(int));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(int));
    
            var sELL_PRICEParameter = sELL_PRICE.HasValue ?
                new ObjectParameter("SELL_PRICE", sELL_PRICE) :
                new ObjectParameter("SELL_PRICE", typeof(decimal));
    
            var sUPLIER_PRICEParameter = sUPLIER_PRICE.HasValue ?
                new ObjectParameter("SUPLIER_PRICE", sUPLIER_PRICE) :
                new ObjectParameter("SUPLIER_PRICE", typeof(decimal));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ADD_PRODUCT", cODEParameter, nAMEParameter, dESCRIPTIONParameter, cATEGORYParameter, sUPPLIERParameter, sTOCKParameter, sELL_PRICEParameter, sUPLIER_PRICEParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_ADD_SALE_CAB(Nullable<int> iDCONTACT, Nullable<decimal> tOTAL_PRICE, string cOMENTS, Nullable<System.DateTime> oRDER_DATE, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE, ObjectParameter iDCAB)
        {
            var iDCONTACTParameter = iDCONTACT.HasValue ?
                new ObjectParameter("IDCONTACT", iDCONTACT) :
                new ObjectParameter("IDCONTACT", typeof(int));
    
            var tOTAL_PRICEParameter = tOTAL_PRICE.HasValue ?
                new ObjectParameter("TOTAL_PRICE", tOTAL_PRICE) :
                new ObjectParameter("TOTAL_PRICE", typeof(decimal));
    
            var cOMENTSParameter = cOMENTS != null ?
                new ObjectParameter("COMENTS", cOMENTS) :
                new ObjectParameter("COMENTS", typeof(string));
    
            var oRDER_DATEParameter = oRDER_DATE.HasValue ?
                new ObjectParameter("ORDER_DATE", oRDER_DATE) :
                new ObjectParameter("ORDER_DATE", typeof(System.DateTime));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ADD_SALE_CAB", iDCONTACTParameter, tOTAL_PRICEParameter, cOMENTSParameter, oRDER_DATEParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE, iDCAB);
        }
    
        public virtual int PA_ADD_SALE_LIN(Nullable<int> n_LIN, Nullable<int> iDPRODUCT, Nullable<int> uNITS, Nullable<int> iDCAB, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var n_LINParameter = n_LIN.HasValue ?
                new ObjectParameter("N_LIN", n_LIN) :
                new ObjectParameter("N_LIN", typeof(int));
    
            var iDPRODUCTParameter = iDPRODUCT.HasValue ?
                new ObjectParameter("IDPRODUCT", iDPRODUCT) :
                new ObjectParameter("IDPRODUCT", typeof(int));
    
            var uNITSParameter = uNITS.HasValue ?
                new ObjectParameter("UNITS", uNITS) :
                new ObjectParameter("UNITS", typeof(int));
    
            var iDCABParameter = iDCAB.HasValue ?
                new ObjectParameter("IDCAB", iDCAB) :
                new ObjectParameter("IDCAB", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ADD_SALE_LIN", n_LINParameter, iDPRODUCTParameter, uNITSParameter, iDCABParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_ADD_SUPPLIER(string nAME, string dESCRIPTION, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ADD_SUPPLIER", nAMEParameter, dESCRIPTIONParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_CHECK_LOGIN(string eMAIL, string pASSWD, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var pASSWDParameter = pASSWD != null ?
                new ObjectParameter("PASSWD", pASSWD) :
                new ObjectParameter("PASSWD", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_CHECK_LOGIN", eMAILParameter, pASSWDParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_DELETE_CATEGORY(string nAME, string dESCRIPTION, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_CATEGORY", nAMEParameter, dESCRIPTIONParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_DELETE_CONTACT(Nullable<int> iD_CONTACT, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iD_CONTACTParameter = iD_CONTACT.HasValue ?
                new ObjectParameter("ID_CONTACT", iD_CONTACT) :
                new ObjectParameter("ID_CONTACT", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_CONTACT", iD_CONTACTParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_DELETE_PRODUCT(Nullable<int> iD_PRODUCT, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iD_PRODUCTParameter = iD_PRODUCT.HasValue ?
                new ObjectParameter("ID_PRODUCT", iD_PRODUCT) :
                new ObjectParameter("ID_PRODUCT", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_PRODUCT", iD_PRODUCTParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_DELETE_SUPPLIER(string nAME, string dESCRIPTION, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_SUPPLIER", nAMEParameter, dESCRIPTIONParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_UPDATE_CATEGORY(Nullable<int> iD, string nAME, string dESCRIPTION, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_CATEGORY", iDParameter, nAMEParameter, dESCRIPTIONParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_UPDATE_CONTACT(Nullable<int> iD_CONTACT, string nAME, string sURNAME, string pHONE, string eMAIL, string aDDRESS, string rOLE, string oBSERVATIONS, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iD_CONTACTParameter = iD_CONTACT.HasValue ?
                new ObjectParameter("ID_CONTACT", iD_CONTACT) :
                new ObjectParameter("ID_CONTACT", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var sURNAMEParameter = sURNAME != null ?
                new ObjectParameter("SURNAME", sURNAME) :
                new ObjectParameter("SURNAME", typeof(string));
    
            var pHONEParameter = pHONE != null ?
                new ObjectParameter("PHONE", pHONE) :
                new ObjectParameter("PHONE", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var aDDRESSParameter = aDDRESS != null ?
                new ObjectParameter("ADDRESS", aDDRESS) :
                new ObjectParameter("ADDRESS", typeof(string));
    
            var rOLEParameter = rOLE != null ?
                new ObjectParameter("ROLE", rOLE) :
                new ObjectParameter("ROLE", typeof(string));
    
            var oBSERVATIONSParameter = oBSERVATIONS != null ?
                new ObjectParameter("OBSERVATIONS", oBSERVATIONS) :
                new ObjectParameter("OBSERVATIONS", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_CONTACT", iD_CONTACTParameter, nAMEParameter, sURNAMEParameter, pHONEParameter, eMAILParameter, aDDRESSParameter, rOLEParameter, oBSERVATIONSParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_UPDATE_PRODUCT(Nullable<int> cODE, string nAME, string dESCRIPTION, Nullable<int> cATEGORY, Nullable<int> sUPPLIER, Nullable<int> sTOCK, Nullable<decimal> sELL_PRICE, Nullable<decimal> sUPLIER_PRICE, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cODEParameter = cODE.HasValue ?
                new ObjectParameter("CODE", cODE) :
                new ObjectParameter("CODE", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var cATEGORYParameter = cATEGORY.HasValue ?
                new ObjectParameter("CATEGORY", cATEGORY) :
                new ObjectParameter("CATEGORY", typeof(int));
    
            var sUPPLIERParameter = sUPPLIER.HasValue ?
                new ObjectParameter("SUPPLIER", sUPPLIER) :
                new ObjectParameter("SUPPLIER", typeof(int));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(int));
    
            var sELL_PRICEParameter = sELL_PRICE.HasValue ?
                new ObjectParameter("SELL_PRICE", sELL_PRICE) :
                new ObjectParameter("SELL_PRICE", typeof(decimal));
    
            var sUPLIER_PRICEParameter = sUPLIER_PRICE.HasValue ?
                new ObjectParameter("SUPLIER_PRICE", sUPLIER_PRICE) :
                new ObjectParameter("SUPLIER_PRICE", typeof(decimal));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_PRODUCT", cODEParameter, nAMEParameter, dESCRIPTIONParameter, cATEGORYParameter, sUPPLIERParameter, sTOCKParameter, sELL_PRICEParameter, sUPLIER_PRICEParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_UPDATE_SUPPLIER(Nullable<int> iD, string nAME, string dESCRIPTION, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_SUPPLIER", iDParameter, nAMEParameter, dESCRIPTIONParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual ObjectResult<string> PAH(string tEXTO)
        {
            var tEXTOParameter = tEXTO != null ?
                new ObjectParameter("TEXTO", tEXTO) :
                new ObjectParameter("TEXTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PAH", tEXTOParameter);
        }
    
        public virtual int PAP(string nOMBRE_PA)
        {
            var nOMBRE_PAParameter = nOMBRE_PA != null ?
                new ObjectParameter("NOMBRE_PA", nOMBRE_PA) :
                new ObjectParameter("NOMBRE_PA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PAP", nOMBRE_PAParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int PA_UPDATE_SALE(Nullable<int> iDCAB, Nullable<int> n_LIN, Nullable<int> iDPRODUCT, Nullable<int> uNITS, Nullable<int> iDLIN, Nullable<decimal> tOTAL_PRICE, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iDCABParameter = iDCAB.HasValue ?
                new ObjectParameter("IDCAB", iDCAB) :
                new ObjectParameter("IDCAB", typeof(int));
    
            var n_LINParameter = n_LIN.HasValue ?
                new ObjectParameter("N_LIN", n_LIN) :
                new ObjectParameter("N_LIN", typeof(int));
    
            var iDPRODUCTParameter = iDPRODUCT.HasValue ?
                new ObjectParameter("IDPRODUCT", iDPRODUCT) :
                new ObjectParameter("IDPRODUCT", typeof(int));
    
            var uNITSParameter = uNITS.HasValue ?
                new ObjectParameter("UNITS", uNITS) :
                new ObjectParameter("UNITS", typeof(int));
    
            var iDLINParameter = iDLIN.HasValue ?
                new ObjectParameter("IDLIN", iDLIN) :
                new ObjectParameter("IDLIN", typeof(int));
    
            var tOTAL_PRICEParameter = tOTAL_PRICE.HasValue ?
                new ObjectParameter("TOTAL_PRICE", tOTAL_PRICE) :
                new ObjectParameter("TOTAL_PRICE", typeof(decimal));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_SALE", iDCABParameter, n_LINParameter, iDPRODUCTParameter, uNITSParameter, iDLINParameter, tOTAL_PRICEParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_DELETE_SALE(Nullable<int> iDCAB, Nullable<int> iNVOKER, string uSUARIO, string cULTURA, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iDCABParameter = iDCAB.HasValue ?
                new ObjectParameter("IDCAB", iDCAB) :
                new ObjectParameter("IDCAB", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cULTURAParameter = cULTURA != null ?
                new ObjectParameter("CULTURA", cULTURA) :
                new ObjectParameter("CULTURA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_SALE", iDCABParameter, iNVOKERParameter, uSUARIOParameter, cULTURAParameter, rETCODE, mENSAJE);
        }
    }
}
