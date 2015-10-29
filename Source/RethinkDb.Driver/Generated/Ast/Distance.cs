












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Distance : ReqlExpr {

    
    
    
/// <summary>
/// <para>Compute the distance between a point and another geometry object. At least one of the geometry objects specified must be a point.</para>
/// </summary>
/// <example><para>Example: Compute the distance between two points on the Earth in kilometers.</para>
/// <code>var point1 = r.point(-122.423246,37.779388);
/// var point2 = r.point(-117.220406,32.719464);
/// r.distance(point1, point2, {unit: 'km'}).run(conn, callback);
/// // result returned to callback 
/// 734.1252496021841
/// </code></example>
        public Distance (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Compute the distance between a point and another geometry object. At least one of the geometry objects specified must be a point.</para>
/// </summary>
/// <example><para>Example: Compute the distance between two points on the Earth in kilometers.</para>
/// <code>var point1 = r.point(-122.423246,37.779388);
/// var point2 = r.point(-117.220406,32.719464);
/// r.distance(point1, point2, {unit: 'km'}).run(conn, callback);
/// // result returned to callback 
/// 734.1252496021841
/// </code></example>
        public Distance (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Compute the distance between a point and another geometry object. At least one of the geometry objects specified must be a point.</para>
/// </summary>
/// <example><para>Example: Compute the distance between two points on the Earth in kilometers.</para>
/// <code>var point1 = r.point(-122.423246,37.779388);
/// var point2 = r.point(-117.220406,32.719464);
/// r.distance(point1, point2, {unit: 'km'}).run(conn, callback);
/// // result returned to callback 
/// 734.1252496021841
/// </code></example>
        public Distance (Arguments args, object optargs)
         : base(TermType.DISTANCE, args, optargs) {
        }


    



    
///<summary>
/// "geo_system": "E_GEO_SYSTEM",
///  "unit": "E_UNIT"
///</summary>
        public Distance this[object optArgs] {
            get
            {
                if(this.OptArgs is Hashtable)
                    throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
                return new Distance (this.Args, optArgs);
            }
        }
        
///<summary>
/// "geo_system": "E_GEO_SYSTEM",
///  "unit": "E_UNIT"
///</summary>
        public Distance optArg(string key, object val){
            if (this.OptArgs != null && !(this.OptArgs is Hashtable))
                throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
            var optArgs = this.OptArgs as Hashtable ?? new Hashtable();
            optArgs[key] = val;
        
            return new Distance (this.Args, optArgs);
        }


    

    


    
    }
}
