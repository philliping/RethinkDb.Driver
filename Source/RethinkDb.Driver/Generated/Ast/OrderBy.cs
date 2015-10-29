












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

    public class OrderBy : ReqlExpr {

    
    
    
/// <summary>
/// <para>Sort the sequence by document values of the given key(s). To specify
/// the ordering, wrap the attribute with either <code>r.asc</code> or <code>r.desc</code>
/// (defaults to ascending).</para>
/// <para>Sorting without an index requires the server to hold the sequence in
/// memory, and is limited to 100,000 documents (or the setting of the <code>arrayLimit</code> option for <a href="/api/javascript/run">run</a>). Sorting with an index can
/// be done on arbitrarily large tables, or after a <code>between</code> command
/// using the same index.</para>
/// </summary>
/// <example><para>Example: Order all the posts using the index <code>date</code>.   </para>
/// <code>r.table('posts').orderBy({index: 'date'}).run(conn, callback)
/// </code>
/// <para>The index must have been previously created with <a href="/api/javascript/index_create/">indexCreate</a>.</para>
/// <code>r.table('posts').indexCreate('date').run(conn, callback)
/// </code>
/// <para>You can also select a descending ordering:</para>
/// <code>r.table('posts').orderBy({index: r.desc('date')}).run(conn, callback)
/// </code></example>
        public OrderBy (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Sort the sequence by document values of the given key(s). To specify
/// the ordering, wrap the attribute with either <code>r.asc</code> or <code>r.desc</code>
/// (defaults to ascending).</para>
/// <para>Sorting without an index requires the server to hold the sequence in
/// memory, and is limited to 100,000 documents (or the setting of the <code>arrayLimit</code> option for <a href="/api/javascript/run">run</a>). Sorting with an index can
/// be done on arbitrarily large tables, or after a <code>between</code> command
/// using the same index.</para>
/// </summary>
/// <example><para>Example: Order all the posts using the index <code>date</code>.   </para>
/// <code>r.table('posts').orderBy({index: 'date'}).run(conn, callback)
/// </code>
/// <para>The index must have been previously created with <a href="/api/javascript/index_create/">indexCreate</a>.</para>
/// <code>r.table('posts').indexCreate('date').run(conn, callback)
/// </code>
/// <para>You can also select a descending ordering:</para>
/// <code>r.table('posts').orderBy({index: r.desc('date')}).run(conn, callback)
/// </code></example>
        public OrderBy (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Sort the sequence by document values of the given key(s). To specify
/// the ordering, wrap the attribute with either <code>r.asc</code> or <code>r.desc</code>
/// (defaults to ascending).</para>
/// <para>Sorting without an index requires the server to hold the sequence in
/// memory, and is limited to 100,000 documents (or the setting of the <code>arrayLimit</code> option for <a href="/api/javascript/run">run</a>). Sorting with an index can
/// be done on arbitrarily large tables, or after a <code>between</code> command
/// using the same index.</para>
/// </summary>
/// <example><para>Example: Order all the posts using the index <code>date</code>.   </para>
/// <code>r.table('posts').orderBy({index: 'date'}).run(conn, callback)
/// </code>
/// <para>The index must have been previously created with <a href="/api/javascript/index_create/">indexCreate</a>.</para>
/// <code>r.table('posts').indexCreate('date').run(conn, callback)
/// </code>
/// <para>You can also select a descending ordering:</para>
/// <code>r.table('posts').orderBy({index: r.desc('date')}).run(conn, callback)
/// </code></example>
        public OrderBy (Arguments args, object optargs)
         : base(TermType.ORDER_BY, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_EXPR"
///</summary>
        public OrderBy this[object optArgs] {
            get
            {
                if(this.OptArgs is Hashtable)
                    throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
                return new OrderBy (this.Args, optArgs);
            }
        }
        
///<summary>
/// "index": "T_EXPR"
///</summary>
        public OrderBy optArg(string key, object val){
            if (this.OptArgs != null && !(this.OptArgs is Hashtable))
                throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
            var optArgs = this.OptArgs as Hashtable ?? new Hashtable();
            optArgs[key] = val;
        
            return new OrderBy (this.Args, optArgs);
        }


    

    


    
    }
}
