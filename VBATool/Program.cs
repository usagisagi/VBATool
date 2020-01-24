using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBATool {
    class Program {
        static string help = $@"
Property -> プロパティを作る
Quit -> 終了
";

        static void Main(string[] args) {
            while(true) {
                Console.WriteLine(help);

                var cmd = Console.ReadLine().ToLower();

                switch (cmd) {
                    case "property":
                        CreateProperty();
                        break;
                    case "quit":
                        return;
                    default:
                        break;
                }
            }
        }


        static void CreateProperty() {
            while (true) {
                Console.WriteLine("変数名を入力: 終了時Quit");

                var argName = Console.ReadLine();
                if (argName.ToLower() == "quit") {
                    return;
                }

                Console.WriteLine("型名を入力");
                var typeName = Console.ReadLine();

                var text = $@"
public function Get{argName}() as {typeName}
	set Get{argName} = {argName}
end function

public sub Set{argName}(arg as {typeName})
	set {argName} = arg
end function
";
                Console.WriteLine(text);
            }
            
        }    
    }


}
