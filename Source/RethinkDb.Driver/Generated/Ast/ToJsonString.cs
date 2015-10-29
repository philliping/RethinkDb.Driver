












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

    public class ToJsonString : ReqlExpr {

    
    
    
/// <summary>
/// <para>Convert a ReQL value or object to a JSON string. You may use either <code>toJsonString</code> or <code>toJSON</code>.</para>
/// </summary>
/// <example><para>Example: Get a ReQL document as a JSON string.</para>
/// <code>&gt; r.table('hero').get(1).toJSON()
/// // result returned to callback
/// '{"id": 1, "name": "Batman", "city": "Gotham", "powers": ["martial arts", "cinematic entrances"]}'
/// </code></example>
        public ToJsonString (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Convert a ReQL value or object to a JSON string. You may use either <code>toJsonString</code> or <code>toJSON</code>.</para>
/// </summary>
/// <example><para>Example: Get a ReQL document as a JSON string.</para>
/// <code>&gt; r.table('hero').get(1).toJSON()
/// // result returned to callback
/// '{"id": 1, "name": "Batman", "city": "Gotham", "powers": ["martial arts", "cinematic entrances"]}'
/// </code></example>
        public ToJsonString (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Convert a ReQL value or object to a JSON string. You may use either <code>toJsonString</code> or <code>toJSON</code>.</para>
/// </summary>
/// <example><para>Example: Get a ReQL document as a JSON string.</para>
/// <code>&gt; r.table('hero').get(1).toJSON()
/// // result returned to callback
/// '{"id": 1, "name": "Batman", "city": "Gotham", "powers": ["martial arts", "cinematic entrances"]}'
/// </code></example>
        public ToJsonString (Arguments args, object optargs)
         : base(TermType.TO_JSON_STRING, args, optargs) {
        }


    



    


    

    


    
    }
}
