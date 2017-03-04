﻿namespace Presentation
{
    class Screen1 : IScreen
    {
        public string Text { get; } =
@"    ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗     
    ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝     
    ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗       
    ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝       
    ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗     
     ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝     
                                                                       
                        ████████╗ ██████╗                              
                        ╚══██╔══╝██╔═══██╗                             
                           ██║   ██║   ██║                             
                           ██║   ██║   ██║                             
                           ██║   ╚██████╔╝                             
                           ╚═╝    ╚═════╝                              
                                                                       
 ██████╗ ██╗ ██╗      ██████╗ ██████╗ ██╗   ██╗██████╗ ███████╗███████╗
██╔════╝████████╗    ██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔════╝
██║     ╚██╔═██╔╝    ██║     ██║   ██║██║   ██║██████╔╝███████╗█████╗  
██║     ████████╗    ██║     ██║   ██║██║   ██║██╔══██╗╚════██║██╔══╝  
╚██████╗╚██╔═██╔╝    ╚██████╗╚██████╔╝╚██████╔╝██║  ██║███████║███████╗
 ╚═════╝ ╚═╝ ╚═╝      ╚═════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝
                                                                      ";

        public DisplayMethod Method { get; } = DisplayMethod.LineByLine;
    }
}
