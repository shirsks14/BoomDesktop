function [Y,r_o, max_d] = dBWithDistance(filename)
[P, ~] = fouriertransform(filename, true);
[max_d,r_o, const] = maxDistance(P);

Y(1) = 20*log10(P);
for i = 1:(max_d - r_o)
    Y(i+1) = 20*log10(soundint(i,const,r_o));
end
% 20*log10(P)
% 20*log10(soundint(400,const,r_o))
% Y=0;
end