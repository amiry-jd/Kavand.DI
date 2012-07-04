using System;
using AutoMapper;

namespace Kavand.DI.Services {

    public abstract class ServiceBase {

        #region AutoMapper helpers; see http://www.kweb.ir/blog/browse-by-tag/automapper

        protected static TDestination Map<TDestination>(object source) {
            return Mapper.Map<TDestination>(source);
        }
        protected static TDestination Map<TDestination>(object source, Action<IMappingOperationOptions> opts) {
            return Mapper.Map<TDestination>(source, opts);
        }
        protected static TDestination Map<TSource, TDestination>(TSource source) {
            return Mapper.Map<TSource, TDestination>(source);
        }
        protected static TDestination Map<TSource, TDestination>(TSource source, TDestination destination) {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        #endregion

    }
}
