function plot_single_wav( data, fs )
%UNTITLED2 Summary of this function goes here
%   Detailed explanation goes here
N = length(data);
t = linspace(0, N/fs, N);
plot(t, data)

end

