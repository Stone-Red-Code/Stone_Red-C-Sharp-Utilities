using System;
using System.Reflection;

namespace Stone_Red_Utilities.Reflection
{
    /// <summary>
    /// Reflection class
    /// </summary>
    public static class Reflection
    {
        /// <summary>
        /// Copies all properties of an object to a new one.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T CopyProperties<T>(this object obj) where T : new()
        {
            T newObj = new T();

            Type objType = obj.GetType();
            Type newObjType = newObj.GetType();

            foreach (PropertyInfo propertyInfo in objType.GetProperties())
            {
                PropertyInfo newObjPropertyInfo = newObjType.GetProperty(propertyInfo.Name);
                if (!(newObjPropertyInfo is null) && newObjPropertyInfo.PropertyType.IsAssignableFrom(propertyInfo.PropertyType))
                {
                    newObjPropertyInfo.SetValue(newObj, propertyInfo.GetValue(obj));
                }
            }

            return newObj;
        }

        /// <summary>
        /// Copies all properties of an object to a different one.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="newObj"></param>
        /// <returns></returns>
        public static T CopyProperties<T>(this object obj, T newObj)
        {
            Type objType = obj.GetType();
            Type newObjType = newObj.GetType();

            foreach (PropertyInfo propertyInfo in objType.GetProperties())
            {
                PropertyInfo newObjPropertyInfo = newObjType.GetProperty(propertyInfo.Name);
                if (!(newObjPropertyInfo is null) && newObjPropertyInfo.PropertyType.IsAssignableFrom(propertyInfo.PropertyType))
                {
                    newObjPropertyInfo.SetValue(newObj, propertyInfo.GetValue(obj));
                }
            }

            return newObj;
        }
    }
}