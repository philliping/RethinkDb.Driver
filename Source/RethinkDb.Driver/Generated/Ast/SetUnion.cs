












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

    public class SetUnion : ReqlExpr {

    
    
    
/// <summary>
/// <para>Add a several values to an array and return it as a set (an array with distinct values).</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots and an arc reactor.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').setUnion(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetUnion (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Add a several values to an array and return it as a set (an array with distinct values).</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots and an arc reactor.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').setUnion(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetUnion (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Add a several values to an array and return it as a set (an array with distinct values).</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots and an arc reactor.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').setUnion(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetUnion (Arguments args, object optargs)
         : base(TermType.SET_UNION, args, optargs) {
        }


    



    


    

    


    
    }
}
