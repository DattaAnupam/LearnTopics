### Delegate signature
```
[access_modifier] delegate [return_type] [deligate_name]([parameters])
```

example: <code>public delegate void MyDelegate(string msg);</code>

### Multicast Delegate
> A <code>delegate</code> which points to multiple methods, is called <i><b>multicast</b></i>

> To add methods <code>+</code> is used.

> To remove methods <code>-</code> is used.


### Func

<code>Func</code> is in-built delegate, inside <code>System</code> namespace.

> It can take from 0 to 16 inputs, but the end parameter should be <code>out</code> parameter.

> It does not allow <code>ref</code> and <code>out</code> parameters.

> It must return a value.


### Action

<code>Action</code> is another in-built delegate, inside <code>System</code> namespace.

> It does not return value.
