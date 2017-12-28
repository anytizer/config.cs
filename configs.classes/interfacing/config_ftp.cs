using configs.classes.structures;

namespace configs.classes.interfacing
{
    public abstract class config_ftp : iconfigwriter
    {
        public abstract structure_ftp read();
        public abstract bool write(structure_ftp s);
    }
}
