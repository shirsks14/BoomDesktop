/*
* MATLAB Compiler: 6.2 (R2016a)
* Date: Sun Apr 24 03:12:08 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:soundPlotter,PlotSound,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Sujan\Desktop\Data\SoundPlotter\for_testing" "-v"
* "class{PlotSound:C:\Users\Sujan\Desktop\Data\Circle.m,C:\Users\Sujan\Desktop\Data\dBAtDi
* stance.m,C:\Users\Sujan\Desktop\Data\dBWithDistance.m,C:\Users\Sujan\Desktop\Data\fourie
* rtransform.m,C:\Users\Sujan\Desktop\Data\maxDistance.m,C:\Users\Sujan\Desktop\Data\plotS
* ound.m,C:\Users\Sujan\Desktop\Data\soundint.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace soundPlotter
{

  /// <summary>
  /// The PlotSound class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\Circle.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\dBAtDistance.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\dBWithDistance.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\fouriertransform.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\maxDistance.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\plotSound.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\soundint.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PlotSound : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static PlotSound()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "soundPlotter.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the PlotSound class.
    /// </summary>
    public PlotSound()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PlotSound()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Circle()
    {
      return mcr.EvaluateFunction("Circle", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="radius">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Circle(MWArray radius)
    {
      return mcr.EvaluateFunction("Circle", radius);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Circle(MWArray radius, MWArray center)
    {
      return mcr.EvaluateFunction("Circle", radius, center);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <param name="pathangle">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Circle(MWArray radius, MWArray center, MWArray pathangle)
    {
      return mcr.EvaluateFunction("Circle", radius, center, pathangle);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Circle(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="radius">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Circle(int numArgsOut, MWArray radius)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", radius);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Circle(int numArgsOut, MWArray radius, MWArray center)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", radius, center);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <param name="pathangle">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Circle(int numArgsOut, MWArray radius, MWArray center, MWArray 
                      pathangle)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", radius, center, pathangle);
    }


    /// <summary>
    /// Provides an interface for the Circle function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void Circle(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("Circle", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dBAtDistance()
    {
      return mcr.EvaluateFunction("dBAtDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dBAtDistance(MWArray fileName)
    {
      return mcr.EvaluateFunction("dBAtDistance", fileName);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="distance">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dBAtDistance(MWArray fileName, MWArray distance)
    {
      return mcr.EvaluateFunction("dBAtDistance", fileName, distance);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] dBAtDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBAtDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] dBAtDistance(int numArgsOut, MWArray fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBAtDistance", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="distance">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] dBAtDistance(int numArgsOut, MWArray fileName, MWArray distance)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBAtDistance", fileName, distance);
    }


    /// <summary>
    /// Provides an interface for the dBAtDistance function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void dBAtDistance(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("dBAtDistance", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dBWithDistance()
    {
      return mcr.EvaluateFunction("dBWithDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray dBWithDistance(MWArray filename)
    {
      return mcr.EvaluateFunction("dBWithDistance", filename);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] dBWithDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBWithDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] dBWithDistance(int numArgsOut, MWArray filename)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBWithDistance", filename);
    }


    /// <summary>
    /// Provides an interface for the dBWithDistance function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void dBWithDistance(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("dBWithDistance", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fouriertransform()
    {
      return mcr.EvaluateFunction("fouriertransform", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fouriertransform(MWArray fileName)
    {
      return mcr.EvaluateFunction("fouriertransform", fileName);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="plotCheck">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fouriertransform(MWArray fileName, MWArray plotCheck)
    {
      return mcr.EvaluateFunction("fouriertransform", fileName, plotCheck);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fouriertransform(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fouriertransform", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fouriertransform(int numArgsOut, MWArray fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "fouriertransform", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="plotCheck">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fouriertransform(int numArgsOut, MWArray fileName, MWArray plotCheck)
    {
      return mcr.EvaluateFunction(numArgsOut, "fouriertransform", fileName, plotCheck);
    }


    /// <summary>
    /// Provides an interface for the fouriertransform function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void fouriertransform(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("fouriertransform", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray maxDistance()
    {
      return mcr.EvaluateFunction("maxDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray maxDistance(MWArray p)
    {
      return mcr.EvaluateFunction("maxDistance", p);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] maxDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "maxDistance", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] maxDistance(int numArgsOut, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "maxDistance", p);
    }


    /// <summary>
    /// Provides an interface for the maxDistance function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void maxDistance(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("maxDistance", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the plotSound MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray plotSound()
    {
      return mcr.EvaluateFunction("plotSound", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the plotSound MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray plotSound(MWArray fileName)
    {
      return mcr.EvaluateFunction("plotSound", fileName);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the plotSound MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotSound(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotSound", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the plotSound MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotSound(int numArgsOut, MWArray fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotSound", fileName);
    }


    /// <summary>
    /// Provides an interface for the plotSound function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void plotSound(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("plotSound", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray soundint()
    {
      return mcr.EvaluateFunction("soundint", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="distance">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray soundint(MWArray distance)
    {
      return mcr.EvaluateFunction("soundint", distance);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray soundint(MWArray distance, MWArray const0)
    {
      return mcr.EvaluateFunction("soundint", distance, const0);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <param name="r_o">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray soundint(MWArray distance, MWArray const0, MWArray r_o)
    {
      return mcr.EvaluateFunction("soundint", distance, const0, r_o);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] soundint(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="distance">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] soundint(int numArgsOut, MWArray distance)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", distance);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] soundint(int numArgsOut, MWArray distance, MWArray const0)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", distance, const0);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <param name="r_o">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] soundint(int numArgsOut, MWArray distance, MWArray const0, MWArray 
                        r_o)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", distance, const0, r_o);
    }


    /// <summary>
    /// Provides an interface for the soundint function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void soundint(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("soundint", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
