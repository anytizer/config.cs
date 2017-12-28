# configs.cs

Read and write various kinds of configuration files using C#.


Current capabilities include:

| MySQL Database  | FTP Connection | User Login | API Keys        | Software ID |
| --------------- | -------------- | ---------- | --------------- |------------ |
| Host Name       | Host           | User Name  | Consumer Key    | ID          |
| Port Number     | Port           | Password   | Consumer Secret | Notes       |
| User Name       | User Name      |            |                 |             |
| Password        | Password       |            |                 |             |
| Database Name   | Path           |            |                 |             |

Each kind of configuration has its own set of fields.
And are saved to corresponding .settings files.


## Encoding

To prevent configuration files being edited manually, you can encode them with __base64__ like encoders.
It is an optional step. Do not encode/decode files in the Reader/Writer. [See an example](configs.classes/interfacing/iconfigwriter.cs).


## Dependencies

 * [hashing.cs](https://github.com/anytizer/hashing.cs)
 * [NewtonSoft Json.NET](https://www.newtonsoft.com/json)
